﻿import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { ConfirmationService } from 'primeng/api';

@Component({
    selector: 'features',
    templateUrl: './features.component.html',
    styleUrls: ['./features.component.css'],
    providers: [ConfirmationService]
})

export class FeaturesComponent {
    
    public features: Feature[];
    public featureClients: FeatureClient[];
    public featureFlags: FeatureFlag[];
    public featureFlagsToUpdate: FeatureFlag[];
    public clientConfigurationAttributes: clientConfigurationAttribute[];
    public activeFeature: boolean;
    public httpClient: HttpClient;
    public baseUrl: string;
    public featureId: number;
    public addClientPopUpVisible: boolean;
    public availableClients: Client[];
    public selectedAvailableClientId: number;
    public selectedFeature: Feature;
    public confirmationService: any;
    public selectedServer: Server;

    private noCacheHttpHeader = {
        headers: new HttpHeaders({
            'Cache-Control':'no-cache',
            'Pragma':'no-cache',
            'Expires': 'Sat, 01 Jan 2000 00:00:00 GMT',
            'If-Modified-Since': '0'
        })
    };

    constructor(httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string, confirmationService: ConfirmationService) {

        this.httpClient = httpClient;
        this.baseUrl = baseUrl;
        this.features = [];
        this.featureClients = [];
        this.featureFlags = [];
        this.featureFlagsToUpdate = [];
        this.clientConfigurationAttributes = [];
        this.activeFeature = false;
        this.featureId = 0;
        this.addClientPopUpVisible = false;
        this.availableClients = [];
        this.selectedAvailableClientId = 0;
        this.selectedFeature = { featureId: 0, name: '', active: false };
        this.confirmationService = confirmationService;
        this.selectedServer = { name: '', credsRequiredToUpdate: false };
    }

    getFeatures() {
        this.httpClient.get(this.baseUrl + 'api/Features/GetFeatures/?serverName=' + this.selectedServer.name).subscribe(result => {
            this.features = result as Feature[];
            if (this.features.length > 0) {
                this.loadFeatureInfo(this.features[0].featureId);
            }

        }, error => console.error(error));
    }

    showFeatureStatus(featureId: any) {
        var feature = this.features.find(f => f.featureId == featureId);
        if (feature) {
            this.activeFeature = feature.active;
        }
    }

    getFeatureClients(featureId: any) {

        this.httpClient.get(this.baseUrl + 'api/Features/GetFeatureClients/?featureId=' + featureId, this.noCacheHttpHeader).subscribe(result => {
            this.featureClients = result as FeatureClient[];
        }, error => console.error(error));
        
    }

    getFeatureFlags(featureId: any) {
        this.httpClient.get(this.baseUrl + 'api/Features/GetFeatureFlags/?featureId=' + featureId, this.noCacheHttpHeader).subscribe(result => {
            this.featureFlags = result as FeatureFlag[];
        }, error => console.error(error));
    }

    getClientConfigurationAttribs(featureId: any, clientId: any) {
        this.httpClient.get(this.baseUrl + 'api/Features/GetClientConfigurationAttributes/?featureId=' + featureId + "&clientId=" + clientId, this.noCacheHttpHeader).subscribe(result => {
            this.clientConfigurationAttributes = result as clientConfigurationAttribute[];
            console.log(result);
        }, error => console.error(error));
    }


    loadFeatureInfo(featureId: any) {
        this.showFeatureStatus(featureId);
        this.getFeatureClients(featureId);
        this.getFeatureFlags(featureId);
        this.featureId = featureId;
        this.featureFlagsToUpdate = [];
    }

    showAddClientPopUp()
    {
        this.addClientPopUpVisible = true;
        this.httpClient.get(this.baseUrl + 'api/Features/GetClientsAvailableForFeature/?featureId=' + this.featureId, this.noCacheHttpHeader).subscribe(result => {
            this.availableClients = result as Client[];
        }, error => console.error(error));
    }

    hideAddClientPopUp() {
        this.addClientPopUpVisible = false;
        this.availableClients = [];
    }

    activateFeatureForClient(clientId: any) {
        this.httpClient.get(this.baseUrl + 'api/Features/ActivateFeatureForClient/?featureId=' + this.featureId + "&clientId=" + clientId, this.noCacheHttpHeader).subscribe(result => {
            this.loadFeatureInfo(this.featureId);
        }, error => console.error(error));
    }

    deactivateFeatureForClient(clientId: any) {
        this.httpClient.get(this.baseUrl + 'api/Features/DeactivateFeatureForClient/?featureId=' + this.featureId + "&clientId=" + clientId, this.noCacheHttpHeader).subscribe(result => {
            this.loadFeatureInfo(this.featureId);
        }, error => console.error(error));
    }

    addClientToFeature()
    {
        this.httpClient.get(this.baseUrl + 'api/Features/AddClientToFeature/?featureId=' + this.featureId + "&clientId=" + this.selectedAvailableClientId, this.noCacheHttpHeader).subscribe(result => {
            this.addClientPopUpVisible = false;
            this.loadFeatureInfo(this.featureId);
        }, error => console.error(error));
    }

    removeClientFromFeature(clientId: any) {
        this.httpClient.get(this.baseUrl + 'api/Features/RemoveClientFromFeature/?featureId=' + this.featureId + "&clientId=" + clientId, this.noCacheHttpHeader).subscribe(result => {
            this.loadFeatureInfo(this.featureId);
        }, error => console.error(error));
    }

    changeSelectedAvailableClientId(clientId: any)
    {
        this.selectedAvailableClientId = clientId;
    }

    serverChanged(server: any) {
        console.log(server);
        this.selectedServer = server;
        this.getFeatures();
    }

    confirmRemoveClientFromFeature(clientId: any) {
        this.confirmationService.confirm({
            message: 'Do you want to delete this record?',
            header: 'Delete Confirmation',
            icon: 'fa fa-trash',
            accept: () => {
                this.removeClientFromFeature(clientId);
            },
            reject: () => {
                
            }
        });
    }

    updateFeatureFlag(featureFlag: FeatureFlag)
    {
        this.featureFlagsToUpdate.push(featureFlag);
    }

    saveFeatureFlags() {

        if (this.featureFlagsToUpdate.length > 0) {
            this.httpClient.post<FeatureFlag[]>(this.baseUrl + 'api/Features/SaveFeatureFlags/', this.featureFlagsToUpdate, this.noCacheHttpHeader,).subscribe(result => {
                this.loadFeatureInfo(this.featureId);
            }, error => console.error(error));
        }
    }
}

interface Feature
{
    featureId: number;
    name: string;
    active: boolean;
}

interface FeatureClient {
    featureId: number;
    clientId: number;
    companyName: string;
    active: boolean;
}

interface FeatureFlag {
    featureId: number;
    featureFlagId: number;
    flagName: string;
    flagValue: number;
}

interface clientConfigurationAttribute {
    clientConfigurationAttributeId: number;
    configurationAttributeId: number;
    clientId: number;
    featureId: number;
    description: string;
    value: string;
}

interface Client {
    clientId: number;
    companyName: string;
}

interface Server {
    name: string;
    credsRequiredToUpdate: boolean;
}
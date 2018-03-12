import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { OnInit } from '@angular/core';

@Component({
    selector: 'features',
    templateUrl: './features.component.html',
    styleUrls: ['./features.component.css']
})

export class FeaturesComponent implements OnInit {
    
    public features: Feature[];
    public featureClients: FeatureClient[];
    public activeFeature: boolean;
    public httpClient: HttpClient;
    public baseUrl: string;
    public featureId: number;
    public addClientPopUpVisible: boolean;
    public availableClients: Client[];
    public selectedAvailableClientId: number;
    public selectedFeature: Feature;

    private noCacheHttpHeader = {
        headers: new HttpHeaders({
            'Cache-Control':'no-cache',
            'Pragma':'no-cache',
            'Expires': 'Sat, 01 Jan 2000 00:00:00 GMT',
            'If-Modified-Since': '0'
        })
    };

    constructor(httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {

        this.httpClient = httpClient;
        this.baseUrl = baseUrl;
        this.features = [];
        this.featureClients = [];
        this.activeFeature = false;
        this.featureId = 0;
        this.addClientPopUpVisible = false;
        this.availableClients = [];
        this.selectedAvailableClientId = 0;
        this.selectedFeature = { featureId: 0, name: '', active: false };
    }

    ngOnInit() {
        this.getFeatures();
    }


    getFeatures() {
        this.httpClient.get(this.baseUrl + 'api/Features/GetFeatures').subscribe(result => {
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

    loadFeatureInfo(featureId: any) {
        this.showFeatureStatus(featureId);
        this.getFeatureClients(featureId);
        this.featureId = featureId;
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

    serverChanged(server: string) {
        console.log(server);
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

interface Client {
    clientId: number;
    companyName: string;
}
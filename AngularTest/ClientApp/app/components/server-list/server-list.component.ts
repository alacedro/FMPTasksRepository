import { Component, Inject, EventEmitter, Output } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'server-list',
    templateUrl: './server-list.component.html'
})

export class ServerListComponent {

    public serverList: string[];
    public baseUrl: string;
    public httpClient: HttpClient;
    @Output() onServerChanged = new EventEmitter<string>();

    constructor(httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl;
        this.httpClient = httpClient;
        this.serverList = [];

        this.httpClient.get(baseUrl + 'api/Features/GetServers').subscribe(result => {
            this.serverList = result as string[];
        }, error => console.error(error));
    }

    serverChanged(server: string) {
        this.onServerChanged.emit(server);
    }
}
import { Component, Inject  } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'counter',
    templateUrl: './counter.component.html'
})
export class CounterComponent {
    public currentCount = 0;
    public httpClient: HttpClient;
    public baseUrl: string;

    constructor(httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.httpClient = httpClient;
        this.baseUrl = baseUrl
    }

    public incrementCounter() {
        this.currentCount++;
    }

    importZohoRecords() {
        this.httpClient.get(this.baseUrl + 'api/Features/ImportZohoRecordsFromAPI').subscribe(result => {
            
        }, error => console.error(error));
    }
}

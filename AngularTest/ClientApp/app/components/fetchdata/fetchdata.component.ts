import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http'; 

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public forecasts: WeatherForecast[];
    public cacheForecasts: WeatherForecast[];
    public summaries: any[];

    constructor(httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.forecasts = [];
        this.cacheForecasts = [];
        this.summaries = [];
        httpClient.get(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
            this.cacheForecasts = result as WeatherForecast[];
            this.forecasts = this.cacheForecasts;
        }, error => console.error(error));
        httpClient.get(baseUrl + 'api/SampleData/GetSummaries').subscribe(result => {
            this.summaries = result as any[];
        }, error => console.error(error));
    }

    filterForeCasts(filterVal: any) {
        if (filterVal == "0")
            this.forecasts = this.cacheForecasts;
        else
            this.forecasts = this.cacheForecasts.filter((item) => item.summary == filterVal);
    }
}

interface WeatherForecast {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}

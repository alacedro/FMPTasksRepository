import { Component } from '@angular/core';
import { HostListener } from '@angular/core'

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    @HostListener('window:unload', ['$event'])
    unloadHandler(event: UIEvent) {
        console.log(event);
    }

    @HostListener('window:onbeforeunload', ['$event'])
    beforeUnloadHandler(event: UIEvent) {
        console.log(event);
    }
}

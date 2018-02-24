import { Component } from '@angular/core';
import { Router } from "@angular/router";

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    constructor(private router: Router) {
        this.router.navigate(['features'], { replaceUrl: true });
    }

}

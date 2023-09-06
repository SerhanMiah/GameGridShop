import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
selectedGame: any;
onGameSelected($event: Event) {
throw new Error('Method not implemented.');
}
  title = 'frontend';
}

import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  games = [
    {
      name: 'Game 1',
      image: 'path/to/game1-image.jpg',
      description: 'Description of Game 1.'
    },
    // Add more game objects here
  ];
}

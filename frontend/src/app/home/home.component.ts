import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  games = [
    {
      name: 'Game 1',
      description: 'This is a great game!',
      image: 'path-to-image1.jpg'
    },
    {
      name: 'Game 2',
      description: 'This is another great game!',
      image: 'path-to-image2.jpg'
    },
    // ... add more games
  ];

  constructor() { }

  ngOnInit(): void { }

}

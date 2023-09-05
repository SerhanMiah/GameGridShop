import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-video-game-list',
  templateUrl: './video-game-list.component.html',
  styleUrls: ['./video-game-list.component.css']
})
export class VideoGameListComponent implements OnInit {
  games = [
    { id: 1, name: 'Game 1' },
    { id: 2, name: 'Game 2' },
    // ... add more games
  ];

  constructor() { }

  ngOnInit(): void {
  }

  onSelect(game): void {
    // Handle selection, maybe navigate to the detail page or set a selectedGame variable
  }
}

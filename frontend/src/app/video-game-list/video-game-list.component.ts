import { Component, OnInit } from '@angular/core';
import axios from 'axios';  // <-- Add this line

interface Game {
  id: number;
  name: string;
}

@Component({
  selector: 'app-video-game-list',
  templateUrl: './video-game-list.component.html',
  styleUrls: ['./video-game-list.component.css']
})
export class VideoGameListComponent implements OnInit {
  games: Game[] = [];

  constructor() { }

  async ngOnInit(): Promise<void> {
    try {
      const response = await axios.get('http://localhost:5052/api/game/game');
      this.games = response.data;
    } catch (error) {
      console.error('There was an error fetching the games', error);
    }
  }

  onSelect(game: Game): void {
    // Handle selection
  }
}

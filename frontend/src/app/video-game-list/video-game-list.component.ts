import { Component, OnInit } from '@angular/core';
import axios from 'axios';
import { Router } from '@angular/router';  // Import Router

interface Game {
  id: number;
  title: string;
  description: string;
  price: number;
  coverImageUrl: string;
}

@Component({
  selector: 'app-video-game-list',
  templateUrl: './video-game-list.component.html',
  styleUrls: ['./video-game-list.component.css']
})
export class VideoGameListComponent implements OnInit {
  games: Game[] = [];

  // Inject Router into the constructor
  constructor(private router: Router) {}

  async ngOnInit(): Promise<void> {
    try {
        const { data } = await axios.get('http://localhost:5052/api/Game');

        // Check if data exists
        if (!data) {
            console.error('Received no data from API.');
            return;
        }

        // Check if $values exists and is an array
        if (!data.$values || !Array.isArray(data.$values)) {
            console.error('Data does not contain a valid $values array:', data);
            return;
        }

        // Map the games from the $values property
        this.games = data.$values.map((gameData: {
            gameId: number;
            title: string;
            description: string;
            price: number;
            coverImageUrl: string;
        }) => ({
            id: gameData.gameId,
            title: gameData.title,
            description: gameData.description,
            price: gameData.price,
            coverImageUrl: gameData.coverImageUrl,
        }));

        // Log the mapped games for verification
        console.log('Mapped games:', this.games);

    } catch (error) {
        console.error('There was an error fetching the games', error);
    }
  }

  // Updated onSelect to use the router to navigate to the game details page
  onSelect(game: Game): void {
    this.router.navigate(['/game', game.id]);
  }
}

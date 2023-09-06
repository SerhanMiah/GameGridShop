import { Component, OnInit } from '@angular/core';
import axios from 'axios';
import { ActivatedRoute, Router } from '@angular/router';

interface Game {
  id: number;
  title: string;
  description: string;
  price: number;
  coverImageUrl: string;
  createdDate: string;  // Assuming a string representation of a date
  developer: string;
  gameGenre: number;   // The data you provided gives a number, but you might want to change this to a string or some enum based on your needs
  gameId: number;
  gamePlatform: number; // Similar to gameGenre, this might better be a string or enum based on your actual data set
  images: {
    $id: string;
    $values: any[]; // This is an array, but you might want to further specify its type if you know the data structure of the images
  };
  publisher: string;
  websiteUrl: string;
  youtubeTrailerId: string;  // You might consider changing this to "youtubeTrailerUrl" if it's always going to be a URL
}


@Component({
  selector: 'app-video-game-detail',
  templateUrl: './video-game-detail.component.html',
  styleUrls: ['./video-game-detail.component.css']
})
export class VideoGameDetailComponent implements OnInit {
  selectedGame: Game | undefined;

  constructor(
    private route: ActivatedRoute,
    private router: Router  // Imported Router but not used in the code below, you can remove if not needed
  ) { }

  async ngOnInit(): Promise<void> {
    const id = this.route.snapshot.paramMap.get('id');
    if (id === null) {
      console.error('No game ID provided in route.');
      return;
    }
    const gameId = +id;
    
    try {
      const { data } = await axios.get(`http://localhost:5052/api/Game/${gameId}`);
      console.log(data)
      if (data) {
        this.selectedGame = {
          id: data.gameId,
          title: data.title,
          description: data.description,
          price: data.price,
          coverImageUrl: data.coverImageUrl,
          createdDate: data.createdDate,
          developer: data.developer,
          gameGenre: data.gameGenre,
          gameId: data.gameId,
          gamePlatform: data.gamePlatform,
          images: data.images,
          publisher: data.publisher,
          websiteUrl: data.websiteUrl,
          youtubeTrailerId: data.youtubeTrailerId
        };
        
      } else {
        console.error('No game data found for ID:', gameId);
      }
    } catch (error) {
      console.error('There was an error fetching the game:', error);
    }
  }
}

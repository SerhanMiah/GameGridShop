import { Component, OnInit } from '@angular/core';
import axios from 'axios';
import { ActivatedRoute, Router } from '@angular/router';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';


interface GameImage {
  imageId: number;
  imageUrl?: string;
  gameId: number;
}

interface Edition {
  editionId: number;
  name: string;
  price: number;
  gameId: number;
  DLCs?: DLC[];
}

interface DLC {
  DLCId: number;
  name: string;
  description: string;
  price: number;
  releaseDate: string; // Assuming a string representation of a date
  gameId: number;
}

interface GameTag {
  gameId: number;
  tagId: number;
}

enum Genre {
  Action,
  Adventure,
  RPG,
  // ... (other enum values)
  GrandStrategy,
  HackAndSlash
}

enum Platform {
  PC,
  PS4,
  PS5,
  XboxOne,
  XboxSeriesX,
  Switch,
  Mobile
}

enum GameRating {
  E,
  Mature,
  Age15Plus,
  Age12Plus
}

interface Game {
  gameId: number;
  title?: string;
  description?: string;
  price: number;
  gameGenre: Genre;
  gamePlatform: Platform;
  developer?: string;
  publisher?: string;
  coverImageUrl?: string;
  youtubeTrailerId?: string;
  websiteUrl?: string;
  createdDate: string;
  modifiedDate?: string;  // Assuming a string representation of a date
  images?: GameImage[];
  rating: GameRating;
  gameTags: GameTag[];
  editions: Edition[];
  dlcs: DLC[];
  // ... (other properties if needed, like reviews, cart items, etc.)
}


@Component({
  selector: 'app-video-game-detail',
  templateUrl: './video-game-detail.component.html',
  styleUrls: ['./video-game-detail.component.css']
})
export class VideoGameDetailComponent implements OnInit {
  selectedGame: Game | undefined;
  errorMessage: string | undefined;
  gameData: any;

  constructor(
    private route: ActivatedRoute,
    private sanitizer: DomSanitizer,
    private router: Router 
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
                  ...data, 
                  images: data.images.$values,  
                  dlcs: data.dlcs.$values,
                  editions: data.editions.$values,
              };
          }
      } catch (error) {
          console.error('There was an error fetching the game:', error);
          this.handleError(error);
      }
  }

  private handleError(error: any) {
    this.errorMessage = 'There was an issue fetching the game. Please try again later.';
  }

  getSafeUrl(videoId: string): SafeResourceUrl {
    return this.sanitizer.bypassSecurityTrustResourceUrl(`https://www.youtube.com/embed/${videoId}`);
}

onBuyHover() {
  // Add logic to change the button's appearance on hover (perhaps increase size slightly or change color).
}

onBuyLeave() {
  // Revert the button's appearance when the mouse is no longer hovering over it.
}



}

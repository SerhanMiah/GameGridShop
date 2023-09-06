import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-video-game-detail',
  templateUrl: './video-game-detail.component.html',
  styleUrls: ['./video-game-detail.component.css']
})
export class VideoGameDetailComponent implements OnInit {
  @Input() selectedGame: any;

  constructor() { }

  ngOnInit(): void {
  }
}

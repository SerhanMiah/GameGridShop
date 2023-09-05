import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VideoGameDetailComponent } from './video-game-detail.component';

describe('VideoGameDetailComponent', () => {
  let component: VideoGameDetailComponent;
  let fixture: ComponentFixture<VideoGameDetailComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VideoGameDetailComponent]
    });
    fixture = TestBed.createComponent(VideoGameDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

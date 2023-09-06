import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HomeComponent } from './home/home.component';

import { ProfileComponent } from './profile/profile.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { VideoGameListComponent } from './video-game-list/video-game-list.component';
import { VideoGameDetailComponent } from './video-game-detail/video-game-detail.component';
import { NavigationBarComponent } from './navigation-bar/navigation-bar.component';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ProfileComponent,
    LoginComponent,
    RegisterComponent,
    VideoGameListComponent,
    VideoGameDetailComponent,
    NavigationBarComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

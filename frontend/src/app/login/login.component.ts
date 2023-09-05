import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    // You can perform API requests here using HttpClient
    this.fetchData();
  }

  fetchData() {
    // Example: Making a GET request
    this.http.get('https://api.example.com/data').subscribe((response) => {
      // Handle the response data
    });
  }
}

import { Component, OnInit } from '@angular/core';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-server-error',
  templateUrl: './server-error.component.html',
  styleUrls: ['./server-error.component.css']
})
export class ServerErrorComponent implements OnInit {
  error: any

  constructor(private route: Router) {
    const navigation = this.route.getCurrentNavigation();
    this.error = navigation?.extras?.state?.error;
  }
  ngOnInit(): void {
  }

}

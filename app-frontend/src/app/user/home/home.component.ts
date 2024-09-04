import { Component, OnInit } from '@angular/core';
import { User } from '../user';
import { UserService } from '../user.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  allUsers: User[] = [];

  constructor(private userService: UserService) {}

  ngOnInit(): void {}

  getAllUser(): void {
    this.userService.getAll().subscribe((data) => {
      this.allUsers = data;
    })
  }
}

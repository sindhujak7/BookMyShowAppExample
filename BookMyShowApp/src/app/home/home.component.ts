import { Component } from '@angular/core';
import { HomeService } from '../services/home.service';
import { NgModule } from '@angular/core';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import {MatCardModule}  from '@angular/material/card';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
public Cities:any=[];
decodedToken: any;
public selectedCityId:number=0;
  constructor( private homservice:HomeService ,private jwtHelper: JwtHelperService){

    this.getCitiesList();
  }
  


  getCitiesList(){
    this.homservice.getCitiesList().subscribe(data => 
      {
        
        this.Cities=data;
        this.selectedCityId = this.Cities[0].id;
      })
  }

}

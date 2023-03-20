import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AngularMaterialModule } from '../../angular-material.module';
import { FormsModule } from '@angular/forms';
import { UserloginService } from '../../services/userlogin.service';
import { Router } from '@angular/router';
import { AlertserviceService } from '../../services/alertservice.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, AngularMaterialModule, FormsModule],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private service: UserloginService,private route:Router ,private alert:AlertserviceService) { }

  ngOnInit(): void {
    localStorage.clear();
  }
  respdata:any;

  ProdceedLogin(logindata: any) {
    if (logindata.valid) {
      this.service.ProceedLogin(logindata.value).subscribe(data => {
       
        this.respdata=data;
        if(this.respdata.status ==true){


          localStorage.setItem('token',this.respdata.tokens.token);
          this.route.navigate(['home']);

        }else{
          this.alert.error("Login Failed");
        }
      });

    }
  }

  RedirectRegister(){
    this.route.navigate(['register']);
  }

}
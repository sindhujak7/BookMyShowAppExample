import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserloginService } from '../../services/userlogin.service'; 
import { AlertserviceService } from '../../services/alertservice.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private router: Router, private service: UserloginService,private alert:AlertserviceService) { }

  ngOnInit(): void {
  }
  respdata: any;

  RedirectLogin() {
    this.router.navigate(['login']);
  }
  reactiveform = new FormGroup({
    Address: new FormControl('', Validators.required),
    City: new FormControl('', Validators.required),
    Phonenumber: new FormControl('', Validators.required),
    Username: new FormControl('', Validators.required),
    Password: new FormControl('', Validators.required),
    Email: new FormControl('', Validators.compose([Validators.required, Validators.email]))
  });
  SaveUser() {
    debugger
    if (this.reactiveform.valid) {
      this.service.Registeration(this.reactiveform.value).subscribe(res => {
        this.respdata = res;
       // if(this.respdata=='Success'){
          //alert.success("Registerted successfully please contact admin for activation");
         this.RedirectLogin();
        // }else{
         
        // }
      });
    }

  }

}

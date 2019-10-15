import { Component, OnInit} from '@angular/core';
import { DeptService } from "./dept.service";
import { Department } from "./Dept";
import { Router } from "@angular/router";

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.scss']
})
export class AddComponent implements OnInit {

 dept=new Department();

    constructor(private es:DeptService,private route:Router) {
      
     }
  
    ngOnInit() {
      
    }

    addDept()
    {
      this.dept.modified_date=new Date()
      this.es.save(this.dept)
     
    }
   
     
   
  }

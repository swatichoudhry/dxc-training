import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Router } from "@angular/router";
import { Department } from "./../Dept";
import { DeptService } from "./../dept.service";

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  department:Department;
  updatediv=false;
  indexposition:number;
  deptlist :Department[];

  constructor(private es:DeptService,private route :Router){
    this.deptlist=this.es.getDept();
    }
  ngOnInit() {
  }
  edit(index:number)
  {   
    console.log("Index "+index);
     this.updatediv=true; 
     this.department=this.deptlist[index];
   }
  deleteDept(index:number)
  {
    this.es.delete(index);
   }
   done(){
     this.updatediv=false
     this.department.modified_date=new Date()

   }
}


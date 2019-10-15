import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Department} from "./Dept";

@Injectable({
  providedIn: 'root'
})
export class DeptService {
  private deptlist:Department[]=[
    {id:101,name:'Engineering',modified_date:new Date('2/10/1967'),groupName:'R and D'},
    {id:102,name:'Marketing',modified_date:new Date('2/9/1997'),groupName:'Sales and Marketing'},
    {id:103,name:'Purchasing',modified_date:new Date('11/4/1989'),groupName:'Inventory Management'},
    {id:104,name:'Sales',modified_date:new Date('4/3/1978'),groupName:'Sales and Marketing'},

  ];

  constructor() { }

  getDept(){
    return this.deptlist;
      }

      save(dept:Department)
    {
      this.deptlist.push(dept);
    }

    // update(dept:Department,index:number)
    // {
    //    this.deptlist[index]=dept;
    //     }
    
    delete(index :number)
    {
      this.deptlist.splice(index,1);
    }
  
}

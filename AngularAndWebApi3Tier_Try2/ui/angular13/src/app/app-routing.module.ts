import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {EmployeeComponent} from './employee/employee.component';
import {DepartmentComponent} from './department/department.component';
import { PrintEmployeeComponent } from './employee/print-employee/print-employee.component';


const routes: Routes = [
{path:'employee',component:EmployeeComponent},
{path:'department',component:DepartmentComponent},
{path:'print',component:PrintEmployeeComponent}//added

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl = "http://localhost:39569/api/";
readonly PhotoUrl = "http://localhost:39569/Photos/";

  constructor(private http:HttpClient) { }

  getDepList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'Department/Get/');
  }

  addDepartment(val:any)
  {
    return this.http.post(this.APIUrl+'Department/Add/',val);
  }

  updateDepartment(val:any)
  {
    return this.http.put(this.APIUrl+'Department/Edit/',val);
  }

  deleteDepartment(val:any)
  {
    return this.http.delete(this.APIUrl+'Department/Delete/'+ val);
  }

  //Employee

  getEmpList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'Employee/Get');
  }

  addEmployee(val:any)
  {
    return this.http.post(this.APIUrl+'Employee/Add/',val);
  }

  updateEmployee(val:any)
  {
    return this.http.put(this.APIUrl+'Employee/Edit/',val);
  }

  deleteEmployee(val:any)
  {
    return this.http.delete(this.APIUrl+'Employee/Delete/'+ val);
  }

  UploadPhoto(val:any)
  {
    return this.http.post(this.APIUrl+'Employee/SaveFile/',val);
  }

  getAllDepartmentNames():Observable<any[]>{
    return this.http.get<any[]>(this.APIUrl+'Department/Get/');
  }

}

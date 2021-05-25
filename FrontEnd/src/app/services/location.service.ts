import { Injectable } from '@angular/core';
import { FoodLocation } from '../food-location';
import { LOCATIONS } from '../mock-locations';
import { Observable, of } from 'rxjs';
import { MessageService } from './message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class LocationService {

  constructor(
    private http: HttpClient,
    private messageService: MessageService) { }

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  items = [];

  private locationsUrl = 'https://localhost:44398/Locations';  // URL to web api

  // why are we using pipe and have 'getLocations' in quotes??? strange
  //getLocations(): Observable<FoodLocation[]> {
  //  return this.http.get<FoodLocation[]>(this.locationsUrl).pipe(
  //    catchError(this.handleError<FoodLocation[]>('getLocations', []))
  //  );
  //}

  getLocations(): void {
    this.http.get<FoodLocation[]>(this.locationsUrl).toPromise().then(data => {
      console.log(data);

    });
    
  }

  getLocation(id: number): Observable<FoodLocation> {
    const url = `${this.locationsUrl}/${id}`;
    return this.http.get<FoodLocation>(url).pipe(
      catchError(this.handleError<FoodLocation>(`getLocation id=${id}`))
    );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  updateLocation(location?: Location): Observable<any> {
    return this.http.put(this.locationsUrl, location, this.httpOptions).pipe(
      catchError(this.handleError<any>('updateLocation'))
    );
  }
}

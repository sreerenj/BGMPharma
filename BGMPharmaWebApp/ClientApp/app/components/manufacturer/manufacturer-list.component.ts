import { Component, Inject, Input, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Router } from "@angular/router";

@Component({
    selector: "manufacturer-list",
    templateUrl: './manufacturer-list.component.html',
    styleUrls:['./manufacturer-list.component.css']
})
export class ManufacturerListComponent implements OnInit {
    manufacturers: Manufacturer[];

    constructor(private http: HttpClient,
        @Inject('BASE_URL') private baseUrl: string,
        private router: Router) {
        this.http = http;
        this.baseUrl = baseUrl;
        
    }

    ngOnInit(): void {
        console.log("List of manufacturers");
        var url = this.baseUrl + "api/manufacturer";
        this.http.get<Manufacturer[]>(url).subscribe(result => {
                this.manufacturers = result;
            },
            error => console.error(error));
    }

}
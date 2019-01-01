﻿import { Component, Inject, Input, OnInit, ViewChild } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Router } from "@angular/router";
import { MatPaginator, MatTableDataSource } from "@angular/material";
@Component({
    selector: "manufacturer-list",
    templateUrl: './manufacturer-list.component.html',
    styleUrls: ['./manufacturer-list.component.css']
})
export class ManufacturerListComponent implements OnInit {

    isLoading : boolean = true;
    displayedColumns = ['name', 'address', 'district'];
    elementData = new MatTableDataSource();
    @ViewChild(MatPaginator) paginator: MatPaginator;

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
                this.elementData.data = result;
                this.elementData.paginator = this.paginator;
                this.isLoading = false;
            },
            error => console.error(error));
    }
}


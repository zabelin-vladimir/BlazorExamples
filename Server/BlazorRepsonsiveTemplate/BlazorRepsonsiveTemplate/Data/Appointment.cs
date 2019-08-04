﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRepsonsiveTemplate.Data
{
    public static partial class AppointmentCollection
    {

        public class Appointment
        {
            public Appointment() { }

            public int AppointmentId { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Caption { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public int Label { get; set; }
            public int Status { get; set; }
            public bool AllDay { get; set; }
        }
        private static readonly Lazy<List<Appointment>> dataSource = new Lazy<List<Appointment>>(() => {
            DateTime date = DateTimeUtils.CreateWeekStart();
            var dataSource = new List<Appointment>() {
                new Appointment {
                    AppointmentId = 1,
                    Caption = "Website Re-Design Plan",
                    StartDate = date + (new TimeSpan(1, 9, 30, 0)),
                    EndDate = date + (new TimeSpan(1, 11, 30, 0)),
                    Label = 4, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 2,
                    Caption = "Book Flights to San Fran for Sales Trip",
                    StartDate = date + (new TimeSpan(1, 12, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 13, 0, 0)),
                    AllDay = true,
                    Label = 3, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 3,
                    Caption = "Install New Router in Dev Room",
                    StartDate = date + (new TimeSpan(1, 13, 30, 0)),
                    EndDate = date + (new TimeSpan(1, 15, 30, 0)),
                    Label = 5, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 4,
                    Caption = "Approve Personal Computer Upgrade Plan",
                    StartDate = date + (new TimeSpan(2, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(2, 11, 0, 0)),
                    Label = 3, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 5,
                    Caption = "Final Budget Review",
                    StartDate = date + (new TimeSpan(2, 12, 0, 0)),
                    EndDate = date + (new TimeSpan(2, 14, 0, 0)),
                    Label = 4, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 6,
                    Caption = "New Brochures",
                    StartDate = date + (new TimeSpan(2, 14, 30, 0)),
                    EndDate = date + (new TimeSpan(2, 15, 45, 0)),
                    Label = 3, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 7,
                    Caption = "Install New Database",
                    StartDate = date + (new TimeSpan(3, 9, 45, 0)),
                    EndDate = date + (new TimeSpan(3, 11, 15, 0)),
                    Label = 5, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 8,
                    Caption = "Approve New Online Marketing Strategy",
                    StartDate = date + (new TimeSpan(3,  12, 0, 0)),
                    EndDate = date + (new TimeSpan(3, 14, 0, 0)),
                    Label = 4, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 9,
                    Caption = "Upgrade Personal Computers",
                    StartDate = date + (new TimeSpan(3,  15, 15, 0)),
                    EndDate = date + (new TimeSpan(3, 16, 30, 0)),
                    Label = 4, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 10,
                    Caption = "Customer Workshop",
                    StartDate = date + (new TimeSpan(4,  11, 0, 0)),
                    EndDate = date + (new TimeSpan(4, 12, 0, 0)),
                    AllDay = true,
                    Label = 3, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 11,
                    Caption = "Prepare 2015 Marketing Plan",
                    StartDate = date + (new TimeSpan(4,  11, 0, 0)),
                    EndDate = date + (new TimeSpan(4, 13, 30, 0)),
                    Label = 4, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 12,
                    Caption = "Brochure Design Review",
                    StartDate = date + (new TimeSpan(4, 14, 0, 0)),
                    EndDate = date + (new TimeSpan(4, 15, 30, 0)),
                    Label = 4, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 13,
                    Caption = "Create Icons for Website",
                    StartDate = date + (new TimeSpan(5, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(5, 11, 30, 0)),
                    Label = 4, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 14,
                    Caption = "Upgrade Server Hardware",
                    StartDate = date + (new TimeSpan(5, 14, 30, 0)),
                    EndDate = date + (new TimeSpan(5, 16, 0, 0)),
                    Label = 3, 
                    Status = 3
                },
                new Appointment {
                    AppointmentId = 15,
                    Caption = "Launch New Website",
                    StartDate = date + (new TimeSpan(5, 12, 20, 0)),
                    EndDate = date + (new TimeSpan(5, 14, 0, 0)),
                    Label = 3, 
                    Status = 3
                }
            };
            return dataSource;
        });
        public static List<Appointment> DataSource { get { return dataSource.Value; } }

    }
}

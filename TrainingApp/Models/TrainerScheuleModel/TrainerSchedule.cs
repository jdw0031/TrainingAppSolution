﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TrainingApp.Models.TrainerModel;

namespace TrainingApp.Models.TrainerScheuleModel
{
    public class TrainerSchedule
    {
        [Key]
        public int trainerScheduleID { get; set; }

        [Required]
        public DateTime trainerScheduleStartDateTime { get; set; }

        [Required]
        public DateTime trainerScheduleEndDateTime { get; set; }

        [Required]
        public bool isAvailable { get; set; }

        public string trainerId { get; set; }

        [ForeignKey("trainerId")]
        public Trainer trainer { get; set; }

        public TrainerSchedule(DateTime TrainerScheduleStartDateTime, DateTime TrainerScheduleEndDateTime, string TrainerID)
        {
            this.trainerScheduleStartDateTime = TrainerScheduleStartDateTime;
            this.trainerScheduleEndDateTime = TrainerScheduleEndDateTime;
            this.isAvailable = true;
            this.trainerId = TrainerID;
        }
        public TrainerSchedule()
        {

        }
    }
}

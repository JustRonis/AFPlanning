using System;

namespace AFPlanningApi.domain
{
    public class Room
        : Entity
    {
        public Sprint Sprint { get; set; }

        public DateTime SchedulePlanningDateStart {get; set;}
        public DateTime SchedulePlanningDateEnd {get; set;}
        public DateTime PlanningDateStart {get; set;}
        public DateTime PlanningDateEnd {get; set;}

        /// <summary> In minutes.</summary>
        public int Timebox 
        {
            get{return _timebox;}
            set
            {
                if(value == 0)
                    throw new ArgumentException("O timebox precisa ter uma valor maior que zero.");

                if(value > 480)
                    throw new ArgumentException("O timebox não pode ser maior que oito horas");

                _timebox = value;
            }
        } 
        private int _timebox;

        public PlanningPoker PlanningPoker { get; set; }    
    }
}
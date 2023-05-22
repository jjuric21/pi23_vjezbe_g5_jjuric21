using Evaluation_Manager_DS.Models;
using Evaluation_Manager_DS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager_DS.Models {
    public class Student : Person {
        public int Grade { get; set; }

        public List<Evaluation> GetEvaluations() {
            return EvaluationRepository.GetEvaluation(this);
        }

        public int CalculateTotalPoints() {

            int totalPoints = 0;
            foreach (var evaluation in GetEvaluations()) {

                totalPoints += evaluation.Points;

            }
            return totalPoints;
        }

        private bool IsEvaluationComplete() {
            var evaluations = GetEvaluations();
            var activities = ActivityRepository.GetActivities();
            return evaluations.Count == activities.Count;



        }
        public bool HasSignature() {
            bool hasSignature = true;
            if (IsEvaluationComplete() == true) {
                foreach (var evaluation in GetEvaluations()) {
                    if (evaluation.IsSufficientForSignature() == false) {

                        hasSignature = false;
                        break;
                    }

                }
            } else {
                hasSignature = false;

            }
            return hasSignature;
        }
    }

    public bool HasGrade() {
        bool hasGrade = true;
        if (IsGradeComplete() == true) {
            foreach (var grade in GetGrade()) {
                if (grade.IsSufficientForGrade() == false) {

                    hasGrade = false;
                    break;
                }

            }
        } else {
            hasGrade = false;

        }
        return hasGrade;
    }

    public interface CalculateGrade()
        {
        int grade = 0;
    if(HasGrade() ==true){
        int totalPoints = CalculateTotalPoints();
    if(totalPoints >= 91){
        grade = 5
}else if(totalPoints >= 76) { Grade = 4}; ;} 
else if(totalPoints >=50) { grade = 2; }

}
}
}
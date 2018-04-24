using ResterauntReview.dl.Models;

namespace RestarauntReviews.bl
{
    interface IReviewFunctions
    {

        void GetResterauntReviews(string name);
        void GetAverageResterauntReviews(int ResterauntId);
        void GetAveragesOfAllResterauntReviews();
    }
}

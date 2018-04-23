namespace RestarauntReviews.bl
{
    interface IReviewFunctions
    {

        void GetResterauntReviews(int ResterauntId);
        void GetAverageResterauntReviews(int ResterauntId);
        void GetAverageOfAllResterauntReviews();
    }
}

namespace DotNetMvcDemo.Web.Models
{
    /*
     * Trust is derived, not blindly stored
       Improves ranking logic
     */
    public class TrustProfile
    {
        public double AverageRating { get; private set; }
        public int TotalBookings { get; private set; }
        public int CompletedBookings { get; private set; }
        public TimeSpan AvgResponseTime { get; private set; }

        protected TrustProfile() { }

        public TrustProfile(
            double averageRating,
            int totalBookings,
            int completedBookings,
            TimeSpan avgResponseTime)
        {
            AverageRating = averageRating;
            TotalBookings = totalBookings;
            CompletedBookings = completedBookings;
            AvgResponseTime = avgResponseTime;
        }

        public int CalculateTrustScore()
        {
            return (int)(
                (AverageRating * 20) +
                (CompletedBookings * 0.5) -
                (AvgResponseTime.TotalHours * 2)
            );
        }
    }

}

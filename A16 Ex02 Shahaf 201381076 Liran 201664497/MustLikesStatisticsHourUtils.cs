
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public class MustLikesStatisticsHourUtils
    {
        public void HourAlreadyExistInDictionary(SortedDictionary<int, LikesAggregation> io_DictonaryToChange, int io_LocantionToChange, LikesAggregation io_PostToChange)
        {
            io_DictonaryToChange[io_LocantionToChange].GetAvrageLikes();
        }

        public SortedDictionary<int, LikesAggregation> GetAvgLikesPerHour(FacebookObjectCollection<Post> i_UserPosts)
        {
            SortedDictionary<int, LikesAggregation> likesPerHour = new SortedDictionary<int, LikesAggregation>();

            if (i_UserPosts != null)
            {
                foreach (Post post in i_UserPosts)
                {
                    if (post.CreatedTime != null)
                    {
                        int postHour = post.CreatedTime.Value.Hour;
                        if (likesPerHour.ContainsKey(postHour))
                        {
                            likesPerHour[postHour].addPost(post);
                        }
                        else
                        {
                            LikesAggregation likesAgg = new LikesAggregation(post);
                            likesPerHour.Add(likesAgg.m_Hour, likesAgg);
                        }
                    }
                }
            }

            return likesPerHour;
        }
    }
}

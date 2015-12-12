using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public class MustLikesStatisticsHourUtils
    {
        public void HourAlreadyExistInDictionary(SortedDictionary<int, UserPostsForDictionary> io_DictonaryToChange, int io_LocantionToChange, UserPostsForDictionary io_PostToChange)
        {
            io_DictonaryToChange[io_LocantionToChange].GetAvrageLikes();
        }

        public SortedDictionary<int, UserPostsForDictionary> GetAvgLikesPerHour(FacebookObjectCollection<Post> i_UserPosts)
        {
            SortedDictionary<int, UserPostsForDictionary> m_DictionaryForPosts = new SortedDictionary<int, UserPostsForDictionary>();

            if (i_UserPosts != null)
            {
                foreach (Post post in i_UserPosts)
                {
                    if (post.CreatedTime != null)
                    {
                        int postHour = post.CreatedTime.Value.Hour;
                        if (m_DictionaryForPosts.ContainsKey(postHour))
                        {
                            m_DictionaryForPosts[postHour].m_NumberOfPosts++;
                            m_DictionaryForPosts[postHour].m_NumberOfLikesForPosts += post.LikedBy.Count;
                        }
                        else
                        {
                            UserPostsForDictionary SinglePost = new UserPostsForDictionary(post);
                            m_DictionaryForPosts.Add(post.CreatedTime.Value.Hour, SinglePost);
                            m_DictionaryForPosts[post.CreatedTime.Value.Hour].GetAvrageLikes();
                        }
                    }
                }
            }

            return m_DictionaryForPosts;
        }
    }
}

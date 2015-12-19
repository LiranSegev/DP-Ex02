using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public class LikesAggregation
    {
        public int m_Hour { get; set; }

        public int m_SumLikes { get; set; }

        public int m_NumOfPosts { get; set; }

        public LikesAggregation(Post i_PostFromUser)
        {
            m_Hour = i_PostFromUser.CreatedTime.Value.Hour;
            m_NumOfPosts = 1;
            m_SumLikes += i_PostFromUser.LikedBy.Count;
        }

        public double GetAvrageLikes()
        {
            return m_SumLikes / m_NumOfPosts;
        }

        public void addPost(Post i_PostFromUser)
        {
            m_SumLikes += i_PostFromUser.LikedBy.Count;
            m_NumOfPosts++;
        }
    }
}

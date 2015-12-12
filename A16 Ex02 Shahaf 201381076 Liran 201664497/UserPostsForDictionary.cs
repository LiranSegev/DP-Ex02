using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public class UserPostsForDictionary
    {
        public int m_NumberOfLikesForPosts { get; set; }

        public int m_NumberOfPosts { get; set; }

        public int m_AvrageLikesPerPost { get; set; }

        public UserPostsForDictionary(Post io_PostFromUser)
        {
            m_NumberOfPosts = 1;
            m_NumberOfLikesForPosts += io_PostFromUser.LikedBy.Count;
            m_AvrageLikesPerPost = io_PostFromUser.LikedBy.Count;
        }

        public void GetAvrageLikes()
        {
            if (m_NumberOfLikesForPosts == 0)
            {
                m_AvrageLikesPerPost = 0;
            }
            else
            {
                m_AvrageLikesPerPost = m_NumberOfLikesForPosts / m_NumberOfPosts;
            }
        }

        public void addPost(Post i_PostFromUser)
        {
            m_NumberOfLikesForPosts += i_PostFromUser.LikedBy.Count;
            m_NumberOfLikesForPosts++;
        }
    }
}

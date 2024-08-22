using CommunityToolkit.Mvvm.ComponentModel;
using HTTP_Client.Services;
using System.Windows.Input;

namespace HTTP_Client.Views;

public partial class NewPage1 : ContentPage
{
	public partial class CreatePostViewModel : ObservableObject
	{
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string body;
        [ObservableProperty]
        string id;
        [ObservableProperty]
        string userId;

        public ICommand SavePostCommand { get; }

        CreatePostViewModel() 
        {
            SavePostCommand = new Command(SavePost);
        }
        public async void SavePost()
        {
            Post post = new Post();
            post newPost = new post();
            post.Title = title;
            post.Body = body;
            post.Id = id;
            post.UserId = userId;

            PostServices postServices = new PostServices();
            newPost = await postServices.SavePostAsync(post)
            }
	}
}
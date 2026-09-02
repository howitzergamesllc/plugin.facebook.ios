using System.Diagnostics;

namespace ShareMauiSample;

public partial class MainPage : ContentPage
{
	private const string _photo = "banner1to1.png";
	private const string _trailer = "swipewritertrim.mp4";
	private bool _initialized;
	private bool sharing;

	public MainPage()
	{
		InitializeComponent();
	}
	
	protected override async void OnAppearing()
	{
		base.OnAppearing();

		if (_initialized)
			return;

		_initialized = true;

		await SetImageMemoryShareBtnContent();
		await SetImageUriShareBtnContent();
		await SetImageSendBtnContent();
		await SetVideoMemoryShareBtnContent();
		await SetVideoUriShareBtnContent();
		await SetVideoSendBtnContent();
		await SetAppShareBtnContent();
		await SetAppSendBtnContent();
	}

	private async Task SetImageMemoryShareBtnContent()
	{
		ImageMemoryShareBtn.Pressed += (s,e) => Console.WriteLine("ImageMemoryShareBtn pressed.");
		ImageMemoryShareBtn.Released += (s,e) => Console.WriteLine("ImageMemoryShareBtn released.");
		ImageMemoryShareBtn.Clicked += (s,e) => Console.WriteLine("ImageMemoryShareBtn clicked.");

		var photo = new SharePhoto(await LoadImageBytes(_photo), false);
		var photoContent = new SharePhotoContent([photo]){ Reference = nameof(ImageMemoryShareBtn).ToString()};
		ImageMemoryShareBtn.ShareContent = photoContent;
	}
	
	
	private async Task SetImageUriShareBtnContent()
	{
		ImageUriShareBtn.Pressed += (s,e) => Console.WriteLine("ImageUriShareBtn pressed.");
		ImageUriShareBtn.Released += (s,e) => Console.WriteLine("ImageUriShareBtn released.");
		ImageUriShareBtn.Clicked += (s,e) => Console.WriteLine("ImageUriShareBtn clicked.");

		var linkContent = GetShareLinkContent("https://howitzergames.com/wp-content/uploads/2025/03/Swipe-Writer-App-Icon.png", nameof(ImageUriShareBtn).ToString());
		ImageUriShareBtn.ShareContent = linkContent;
	}

	private async Task SetImageSendBtnContent()
	{
		ImageSendBtn.Pressed += (s,e) => Console.WriteLine("ImageSendBtn pressed.");
		ImageSendBtn.Released += (s,e) => Console.WriteLine("ImageSendBtn released.");
		ImageSendBtn.Clicked += (s,e) => Console.WriteLine("ImageSendBtn clicked.");

		var linkContent = GetShareLinkContent("https://play-lh.googleusercontent.com/3wB6CwK-0w5nq2FNgvTj9hvX_DttTnsB8nfiTgIVmGIAEXW0typUDypiczHtwKjDZvVx0PCOwS0a3nQXonpG=w5120-h2880-rw", nameof(ImageSendBtn).ToString());
        var dialog = CrossFacebookShare.Current.CreateMessageDialog(linkContent);
		dialog.OnShareCompleted += OnShareCompleted;
		dialog.OnShareFailed += OnShareFailed;
		dialog.OnShareCancelled += OnShareCancelled;
		ImageSendBtn.LinkContent = linkContent;
		ImageSendBtn.MessageDialog = dialog;
	}

	private async void HandleManualMemoryImageShareTouch(object? sender, EventArgs e)
	{
		if(sharing)
			return;

		sharing = true;
		Console.WriteLine($"ManualShareBtn Touched");
		Debug.WriteLine($"ManualShareBtn Touched");

		var photo = new SharePhoto(await LoadImageBytes(_photo), false);
		var photoContent = new SharePhotoContent([photo]){ Reference = nameof(ManualImageShareBtn).ToString()};

		var dialog = CrossFacebookShare.Current.CreateShareDialog(photoContent);
		dialog.OnShareCompleted += OnShareCompleted;
		dialog.OnShareFailed += OnShareFailed;
		dialog.OnShareCancelled += OnShareCancelled;

		dialog.Show();
		sharing = false;
	}
	
	private async void HandleManualMemoryVideoShareTouch(object? sender, EventArgs e)
	{
		if(sharing)
			return;

		sharing = true;
		Console.WriteLine($"ManualShareBtn Touched");
		Debug.WriteLine($"ManualShareBtn Touched");

		var photo = new SharePhoto(await LoadImageBytes(_photo), false);
		var destination = Path.Combine(FileSystem.CacheDirectory, _trailer);
		var video = new ShareVideo(await LoadUri(_trailer), photo);
		var videoContent = new ShareVideoContent(video){ Reference = nameof(ManualVideoShareBtn).ToString()};

		var dialog = CrossFacebookShare.Current.CreateShareDialog(videoContent);
		dialog.OnShareCompleted += OnShareCompleted;
		dialog.OnShareFailed += OnShareFailed;
		dialog.OnShareCancelled += OnShareCancelled;

		dialog.Show();
		sharing = false;
	}
	
	private async void HandleManualSendTouch(object? sender, EventArgs e)
	{
		if(sharing)
			return;

		sharing = true;
		Console.WriteLine($"ManualSendBtn Touched");
		Debug.WriteLine($"ManualSendBtn Touched");
		var linkContent = GetShareLinkContent("https://play-lh.googleusercontent.com/3wB6CwK-0w5nq2FNgvTj9hvX_DttTnsB8nfiTgIVmGIAEXW0typUDypiczHtwKjDZvVx0PCOwS0a3nQXonpG=w5120-h2880-rw", nameof(ManualImageSendBtn).ToString());
        var dialog = CrossFacebookShare.Current.CreateMessageDialog(linkContent);
		dialog.OnShareCompleted += OnShareCompleted;
		dialog.OnShareFailed += OnShareFailed;
		dialog.OnShareCancelled += OnShareCancelled;
		dialog.Show();
		sharing = false;
	}

	private async Task SetVideoMemoryShareBtnContent()
	{
		VideoMemoryShareBtn.Pressed += (s,e) => Console.WriteLine("VideoMemoryShareBtn pressed.");
		VideoMemoryShareBtn.Released += (s,e) => Console.WriteLine("VideoMemoryShareBtn released.");
		VideoMemoryShareBtn.Clicked += (s,e) => Console.WriteLine("VideoMemoryShareBtn clicked.");

		var destination = Path.Combine(FileSystem.CacheDirectory, _trailer);
		var photo = new SharePhoto(await LoadImageBytes(_photo), false);
		var video = new ShareVideo(await LoadUri(_trailer), photo);
		var videoContent = new ShareVideoContent(video){ Reference = nameof(VideoMemoryShareBtn).ToString()};
		VideoMemoryShareBtn.ShareContent = videoContent;
	}

	private async Task SetVideoUriShareBtnContent()
	{
		VideoUriShareBtn.Pressed += (s,e) => Console.WriteLine("VideoUriShareBtn pressed.");
		VideoUriShareBtn.Released += (s,e) => Console.WriteLine("VideoUriShareBtn released.");
		VideoUriShareBtn.Clicked += (s,e) => Console.WriteLine("VideoUriShareBtn clicked.");

		var videoContent = GetShareLinkContent("https://youtube.com/shorts/wwieRs2rDgA?si=gJlaQYIpbZ3o_-SM", nameof(VideoUriShareBtn).ToString());
		VideoUriShareBtn.ShareContent = videoContent;
	}

	private async Task SetVideoSendBtnContent()
	{
		VideoSendBtn.Pressed += (s,e) => Console.WriteLine("ShareBtn pressed.");
		VideoSendBtn.Released += (s,e) => Console.WriteLine("ShareBtn released.");
		VideoSendBtn.Clicked += (s,e) => Console.WriteLine("ShareBtn clicked.");

		var linkContent = GetShareLinkContent("https://youtube.com/shorts/wwieRs2rDgA?si=gJlaQYIpbZ3o_-SM", nameof(VideoSendBtn).ToString());

        var dialog = CrossFacebookShare.Current.CreateMessageDialog(linkContent);

		dialog.OnShareCompleted += OnShareCompleted;
		dialog.OnShareFailed += OnShareFailed;
		dialog.OnShareCancelled += OnShareCancelled;

		VideoSendBtn.LinkContent = linkContent;
		VideoSendBtn.MessageDialog = dialog;
	}

	private async Task SetAppShareBtnContent()
	{
		AppShareBtn.Pressed += (s,e) => Console.WriteLine("AppShareBtn pressed.");
		AppShareBtn.Released += (s,e) => Console.WriteLine("AppShareBtn released.");
		AppShareBtn.Clicked += (s,e) => Console.WriteLine("AppShareBtn clicked.");

		var linkContent = GetShareLinkContent(GetAppDestination(), nameof(AppShareBtn).ToString());

		var dialog = CrossFacebookShare.Current.CreateShareDialog(linkContent); //Unfortuneately the sdk provides no way to observe sharebutton events.

		dialog.OnShareCompleted += OnShareCompleted;
		dialog.OnShareFailed += OnShareFailed;
		dialog.OnShareCancelled += OnShareCancelled;

		AppShareBtn.ShareContent = linkContent;
	}

	private async Task SetAppSendBtnContent()
	{
		AppSendBtn.Pressed += (s,e) => Console.WriteLine("AppSendBtn pressed.");
		AppSendBtn.Released += (s,e) => Console.WriteLine("AppSendBtn released.");
		AppSendBtn.Clicked += (s,e) => Console.WriteLine("AppSendBtn clicked.");

		var linkContent = GetShareLinkContent(GetAppDestination(), nameof(AppSendBtn).ToString());

		var dialog = CrossFacebookShare.Current.CreateMessageDialog(linkContent);

		dialog.OnShareCompleted += OnShareCompleted;
		dialog.OnShareFailed += OnShareFailed;
		dialog.OnShareCancelled += OnShareCancelled;

		AppSendBtn.LinkContent = linkContent;
		AppSendBtn.MessageDialog = dialog;
	}

	private void OnShareCompleted(object? sender, FacebookSharingCompletedEventArgs e)
	{
		if(sender is ISharing sharer)
		{
			Console.WriteLine($"OnShareComplete Sharer: {sharer.ShareContent?.Reference}");
			Debug.WriteLine($"OnShareComplete Sharer: {sharer.ShareContent?.Reference}");
			if(e is not null && e.Results is not null)
			{
				foreach(var kvp in e.Results)
				{
					Console.WriteLine($"OnShareComplete Key: {kvp.Key}, Value: {kvp.Value?.ToString()}");
					Debug.WriteLine($"OnShareComplete Key: {kvp.Key}, Value: {kvp.Value?.ToString()}");
				}
			}
		}
	}

	private void OnShareFailed(object? sender, FacebookSharingFailedEventArgs e)
	{
		if(sender is ISharing sharer)
		{
			Console.WriteLine($"OnShareFailed Sharer: {sharer.ShareContent?.Reference}");
			Debug.WriteLine($"OnShareFailed Sharer: {sharer.ShareContent?.Reference}");
			Console.WriteLine($"OnShareFailed Error: {e.Error.Message}");
			Debug.WriteLine($"OnShareFailed Error: {e.Error.Message}");
		}
	}

	private void OnShareCancelled(object? sender, EventArgs e)
	{
		if(sender is ISharing sharer)
		{
			Console.WriteLine($"OnShareCancelled Sharer: {sharer.ShareContent?.Reference}");
			Debug.WriteLine($"OnShareCancelled Sharer: {sharer.ShareContent?.Reference}");
		}
	}

	private async Task<byte[]> LoadImageBytes(string imageResource)
	{
		await using var stream = await FileSystem.OpenAppPackageFileAsync(imageResource);

		using var ms = new MemoryStream();
		await stream.CopyToAsync(ms);

		return ms.ToArray();
	}

	private async Task<Uri> LoadUri(string resource)
	{
		var destination = Path.Combine(FileSystem.CacheDirectory, resource);

		await using var stream = await FileSystem.OpenAppPackageFileAsync(resource);
		await using var destinationStream = File.Create(destination);

		await stream.CopyToAsync(destinationStream);

		return new Uri(destination);
	}

	private ShareLinkContent GetShareLinkContent(string link, string sender)
	{
		var hashTag = new HashTag("#swipewriter")
		{
			Hash = 1
		};

		return new ShareLinkContent()
		{
			Quote = "Try Swipe Writer!",
			EntityURI = "",
			IsMusicAttachmentAllowed = true,
			ContentUri = new Uri(link),
			Hashtag = hashTag,
			PeopleIds = ["person1", "person2"],
			PlaceId = "",
			Reference = sender,
			PageId = ""
		};
	} 

	private string GetAppDestination()
	{
		return DeviceInfo.Platform == DevicePlatform.iOS ? 
			"https://apps.apple.com/us/app/swipe-writer/id6753996503" :
			"https://play.google.com/store/apps/details?id=com.howitzergames.swipewriter&pcampaignid=web_share";
	}
}

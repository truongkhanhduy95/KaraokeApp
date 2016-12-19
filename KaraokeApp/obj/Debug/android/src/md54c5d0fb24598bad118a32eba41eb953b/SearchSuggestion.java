package md54c5d0fb24598bad118a32eba41eb953b;


public class SearchSuggestion
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.arlib.floatingsearchview.suggestions.model.SearchSuggestion,
		android.os.Parcelable
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getBody:()Ljava/lang/String;:GetGetBodyHandler:FloatingSearchViews.Suggestions.Models.ISearchSuggestionInvoker, FloatingSearchView\n" +
			"n_getCreator:()Landroid/os/Parcelable$Creator;:GetGetCreatorHandler:FloatingSearchViews.Suggestions.Models.ISearchSuggestionInvoker, FloatingSearchView\n" +
			"n_setBodyText:(Landroid/widget/TextView;)V:GetSetBodyText_Landroid_widget_TextView_Handler:FloatingSearchViews.Suggestions.Models.ISearchSuggestionInvoker, FloatingSearchView\n" +
			"n_setLeftIcon:(Landroid/widget/ImageView;)Z:GetSetLeftIcon_Landroid_widget_ImageView_Handler:FloatingSearchViews.Suggestions.Models.ISearchSuggestionInvoker, FloatingSearchView\n" +
			"n_describeContents:()I:GetDescribeContentsHandler:Android.OS.IParcelableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_writeToParcel:(Landroid/os/Parcel;I)V:GetWriteToParcel_Landroid_os_Parcel_IHandler:Android.OS.IParcelableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("KaraokeApp.SearchSuggestion, KaraokeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SearchSuggestion.class, __md_methods);
	}


	public SearchSuggestion () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SearchSuggestion.class)
			mono.android.TypeManager.Activate ("KaraokeApp.SearchSuggestion, KaraokeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public SearchSuggestion (java.lang.String p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == SearchSuggestion.class)
			mono.android.TypeManager.Activate ("KaraokeApp.SearchSuggestion, KaraokeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
	}


	public java.lang.String getBody ()
	{
		return n_getBody ();
	}

	private native java.lang.String n_getBody ();


	public android.os.Parcelable.Creator getCreator ()
	{
		return n_getCreator ();
	}

	private native android.os.Parcelable.Creator n_getCreator ();


	public void setBodyText (android.widget.TextView p0)
	{
		n_setBodyText (p0);
	}

	private native void n_setBodyText (android.widget.TextView p0);


	public boolean setLeftIcon (android.widget.ImageView p0)
	{
		return n_setLeftIcon (p0);
	}

	private native boolean n_setLeftIcon (android.widget.ImageView p0);


	public int describeContents ()
	{
		return n_describeContents ();
	}

	private native int n_describeContents ();


	public void writeToParcel (android.os.Parcel p0, int p1)
	{
		n_writeToParcel (p0, p1);
	}

	private native void n_writeToParcel (android.os.Parcel p0, int p1);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

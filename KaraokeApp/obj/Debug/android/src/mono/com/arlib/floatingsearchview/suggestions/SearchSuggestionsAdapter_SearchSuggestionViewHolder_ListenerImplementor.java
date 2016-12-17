package mono.com.arlib.floatingsearchview.suggestions;


public class SearchSuggestionsAdapter_SearchSuggestionViewHolder_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.arlib.floatingsearchview.suggestions.SearchSuggestionsAdapter.SearchSuggestionViewHolder.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemClicked:(I)V:GetOnItemClicked_IHandler:FloatingSearchViews.Suggestions.SearchSuggestionsAdapter/SearchSuggestionViewHolder/IListenerInvoker, FloatingSearchView\n" +
			"n_onMoveItemToSearchClicked:(I)V:GetOnMoveItemToSearchClicked_IHandler:FloatingSearchViews.Suggestions.SearchSuggestionsAdapter/SearchSuggestionViewHolder/IListenerInvoker, FloatingSearchView\n" +
			"";
		mono.android.Runtime.register ("FloatingSearchViews.Suggestions.SearchSuggestionsAdapter+SearchSuggestionViewHolder+IListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SearchSuggestionsAdapter_SearchSuggestionViewHolder_ListenerImplementor.class, __md_methods);
	}


	public SearchSuggestionsAdapter_SearchSuggestionViewHolder_ListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SearchSuggestionsAdapter_SearchSuggestionViewHolder_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("FloatingSearchViews.Suggestions.SearchSuggestionsAdapter+SearchSuggestionViewHolder+IListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onItemClicked (int p0)
	{
		n_onItemClicked (p0);
	}

	private native void n_onItemClicked (int p0);


	public void onMoveItemToSearchClicked (int p0)
	{
		n_onMoveItemToSearchClicked (p0);
	}

	private native void n_onMoveItemToSearchClicked (int p0);

	private java.util.ArrayList refList;
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

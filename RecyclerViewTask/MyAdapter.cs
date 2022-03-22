using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;

namespace RecyclerViewTask
{
    public class MyAdapter : RecyclerView.Adapter
    {
        private myDetailsViewModel myDetailsViewModel;
        private Context mainActivity;

        public MyAdapter(myDetailsViewModel myDetailsViewModel, Context mainActivity)
        {
            this.myDetailsViewModel = myDetailsViewModel;
            this.mainActivity = mainActivity;
        }

        public override int ItemCount => myDetailsViewModel.NumberFriend;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MyViewHolder viewHolder = holder as MyViewHolder;
            viewHolder.Binddata(myDetailsViewModel, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.myView, parent, false);
            return new MyViewHolder(view);
        }
    }

    public class MyViewHolder : RecyclerView.ViewHolder
    {
        public ImageView imageView;
        public TextView mytextName;
        public TextView mytextDetails;

        public MyViewHolder(View itemView) : base(itemView)
        {
            imageView = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            mytextName = itemView.FindViewById<TextView>(Resource.Id.textViewOne);
            mytextDetails = itemView.FindViewById<TextView>(Resource.Id.textViewTwo);
        }

        internal void Binddata(myDetailsViewModel myDetailsViewModel, int position)
        {
            imageView.SetImageResource(myDetailsViewModel[position].PhotoId);
            mytextName.Text = myDetailsViewModel[position].Name;
            mytextDetails.Text = myDetailsViewModel[position].Description;
        }
    }
}
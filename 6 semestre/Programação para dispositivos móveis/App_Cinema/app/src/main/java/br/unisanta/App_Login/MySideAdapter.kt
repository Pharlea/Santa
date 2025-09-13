// MyAdapter.kt
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import br.unisanta.App_Login.Filme
import br.unisanta.App_Login.R

class MySideAdapter(private val itemList: List<Filme>) :
    RecyclerView.Adapter<MySideAdapter.MyViewHolder>() {

    // Describes an item view and metadata about its place within the RecyclerView.
    inner class MyViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
        val itemTextView: TextView = itemView.findViewById(R.id.tv_nome_filme)
        val itemTextView2: TextView = itemView.findViewById(R.id.tv_genero)
        val itemTextView3: TextView = itemView.findViewById(R.id.tv_nota)
    }

    // Called when RecyclerView needs a new ViewHolder of the given type to represent an item.
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MyViewHolder {
        // Create a new view, which defines the UIof the list item
        val view = LayoutInflater.from(parent.context)
            .inflate(R.layout.item_layout, parent, false) // Use your item_layout.xml
        return MyViewHolder(view)
    }

    // Called by RecyclerView to display the data at the specified position.
    override fun onBindViewHolder(holder: MyViewHolder, position: Int) {
        // Get element from your dataset at this position and replace the
        // contents of the view with that element
        val currentItem = itemList[position]
        holder.itemTextView.text = currentItem.nome
        holder.itemTextView2.text = currentItem.genero
        holder.itemTextView3.text = currentItem.nota
    }

    // Return the size of your dataset (invoked by the layout manager)
    override fun getItemCount() = itemList.size
}
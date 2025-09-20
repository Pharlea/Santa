import android.net.Uri
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.TextView
import android.widget.VideoView
import androidx.recyclerview.widget.RecyclerView
import unisanta.br.tpdesafio.Filme
import unisanta.br.tpdesafio.FilmeRepository
import unisanta.br.tpdesafio.R

class Adapter(private val itemList: List<Filme>) :
    RecyclerView.Adapter<Adapter.MyViewHolder>() {

    inner class MyViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
        val videoView: VideoView = itemView.findViewById(R.id.videoView)
        val tituloTextView: TextView = itemView.findViewById(R.id.tv_titulo)
        val descricaoTextView: TextView = itemView.findViewById(R.id.tv_descricao)
        val notaTextView: TextView = itemView.findViewById(R.id.tv_nota)
        val btDeletar: Button = itemView.findViewById(R.id.bt_excluir)
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MyViewHolder {
        val view = LayoutInflater.from(parent.context)
            .inflate(R.layout.item, parent, false)
        return MyViewHolder(view)
    }

    override fun onBindViewHolder(holder: MyViewHolder, position: Int) {
        val currentItem = itemList[position]

        // Texto
        holder.tituloTextView.text = currentItem.nome
        holder.descricaoTextView.text = currentItem.descricao
        holder.notaTextView.text = currentItem.nota

        // Vídeo (pode ser de URL ou local no raw)
        val uri = Uri.parse(currentItem.link)
        holder.videoView.setVideoURI(uri)
        holder.videoView.seekTo(1)
        holder.videoView.setOnClickListener {
            if (holder.videoView.isPlaying) {
                holder.videoView.pause()
            } else {
                holder.videoView.start()
            }
        }

        holder.btDeletar.setOnClickListener{
            val filme = Filme(currentItem.nome, currentItem.descricao, currentItem.nota, currentItem.link)
            FilmeRepository.filmes.remove(filme)
        }
    }

    override fun getItemCount() = itemList.size
}
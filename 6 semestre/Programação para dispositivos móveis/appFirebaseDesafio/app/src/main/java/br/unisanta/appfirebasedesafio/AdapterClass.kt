package br.unisanta.appfirebasedesafio

import Pedido
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.google.firebase.Firebase
import com.google.firebase.firestore.firestore

class PedidoAdapter(
    private val lista: List<Pedido>,
    private val isAdmin: Boolean
) : RecyclerView.Adapter<PedidoAdapter.PedidoViewHolder>() {

    private val db = Firebase.firestore

    class PedidoViewHolder(item: View) : RecyclerView.ViewHolder(item) {
        val txtNome: TextView = item.findViewById(R.id.tv_nome_item)
        val txtPreco: TextView = item.findViewById(R.id.tv_preco_item)
        val txtStatus: TextView = item.findViewById(R.id.tv_status_item)
        val btnStatus: Button = item.findViewById(R.id.btn_alterar_status)
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): PedidoViewHolder {
        val v = LayoutInflater.from(parent.context)
            .inflate(R.layout.activity_item_pedido, parent, false)
        return PedidoViewHolder(v)
    }

    override fun onBindViewHolder(holder: PedidoViewHolder, position: Int) {
        val p = lista[position]

        holder.txtNome.text = p.nome
        holder.txtPreco.text = p.preco
        holder.txtStatus.text = "Status: ${p.status}"

        if (isAdmin) {
            holder.btnStatus.visibility = View.VISIBLE
            holder.btnStatus.setOnClickListener {
                val novoStatus = when (p.status) {
                    "Em espera" -> "Em preparo"
                    "Em preparo" -> "Pronto"
                    else -> "Entregue"
                }

                db.collection("pedidos")
                    .whereEqualTo("nome", p.nome)
                    .whereEqualTo("usuarioEmail", p.usuarioEmail)
                    .get()
                    .addOnSuccessListener { docs ->
                        for (d in docs) {
                            d.reference.update("status", novoStatus)
                        }
                        p.status = novoStatus
                        notifyItemChanged(position)
                    }
            }
        } else {
            holder.btnStatus.visibility = View.GONE
        }
    }

    override fun getItemCount() = lista.size
}


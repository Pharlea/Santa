import java.io.Serializable

data class Pedido(
    var nome: String = "",
    var preco: String = "",
    var status: String = "Pendente",
    var usuarioEmail: String = ""   // <-- CAMPO necessário no Adapter e no Firebase
)



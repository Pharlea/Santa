package desafio.asenjo.firebase;

import java.io.FileInputStream;
import java.io.IOException;
import java.nio.file.Paths;
import java.util.concurrent.ExecutionException;

import com.google.api.core.ApiFuture;
import com.google.auth.oauth2.GoogleCredentials;
import com.google.cloud.firestore.DocumentReference;
import com.google.cloud.firestore.DocumentSnapshot;
import com.google.cloud.firestore.Firestore;
import com.google.cloud.firestore.FirestoreOptions;

public class LivroDAL {

    private static Firestore db;

    public static void conecta() {
        try {
            // Obtém o diretório atual de execução do programa
            String caminhoProjeto = System.getProperty("user.dir");

            // Concatena o caminho do arquivo de credenciais com o diretório do projeto
            String caminhoArquivoCredenciais = Paths.get(caminhoProjeto, "src", "main", "resources", "desafioasenjo-606e5-firebase-adminsdk-fbsvc-d5f3ab1ed7.json").toString();

            // Carrega o arquivo de credenciais
            FileInputStream serviceAccount = new FileInputStream(caminhoArquivoCredenciais);

            FirestoreOptions firestoreOptions = FirestoreOptions.newBuilder()
                    .setCredentials(GoogleCredentials.fromStream(serviceAccount))
                    .build();

            db = firestoreOptions.getService();
        } catch (IOException e) {
            Erro.setErro("Erro ao conectar ao Firestore: " + e.getMessage());
        }
    }

    public static void inseriLivro(Livro umlivro) {
        try {
            db.collection("livros").document(umlivro.getTitulo()).set(umlivro);
        } catch (Exception e) {
            Erro.setErro("Erro ao inserir livro: " + e.getMessage());
        }
    }

    public static void consultaLivro(Livro umlivro) {
        try {
            DocumentReference docRef = db.collection("livros").document(umlivro.getTitulo());
            ApiFuture<DocumentSnapshot> future = docRef.get();
            DocumentSnapshot document = future.get();

            if (document.exists()) {
                umlivro.setAutor(document.getString("autor"));
                umlivro.setEditora(document.getString("editora"));
                umlivro.setAnoEdicao(document.getString("anoEdicao"));
                umlivro.setLocalizacao(document.getString("localizacao"));
            } else
                Erro.setErro("Livro não localizado.");

        } catch (InterruptedException | ExecutionException e) {
            Erro.setErro("Erro ao consultar livro: " + e.getMessage());
        }
    }

    public static void deletaLivro(Livro umlivro) {
        try {
            DocumentReference docRef = db.collection("livros").document(umlivro.getTitulo());
            ApiFuture<DocumentSnapshot> future = docRef.get();
            DocumentSnapshot document = future.get();

            if (document.exists()) {
                try {
                    db.collection("livros").document(umlivro.getTitulo()).delete();
                } catch (Exception e) {
                    Erro.setErro("Erro ao deletar livro: " + e.getMessage());
                }
            } else
                Erro.setErro("Livro não localizado.");
        } catch (InterruptedException | ExecutionException e) {
            Erro.setErro("Erro ao consultar livro: " + e.getMessage());
        }
    }
}

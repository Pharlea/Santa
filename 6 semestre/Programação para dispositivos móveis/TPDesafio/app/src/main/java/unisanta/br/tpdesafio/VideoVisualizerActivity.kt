package unisanta.br.tpdesafio

import Adapter
import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.google.android.material.floatingactionbutton.FloatingActionButton

class VideoVisualizerActivity : AppCompatActivity(R.layout.activity_video_visualizer) {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val fabReturn = findViewById<FloatingActionButton>(R.id.fab_return)
        val rcm = findViewById<RecyclerView>(R.id.RecyclerView)
        rcm.layoutManager = LinearLayoutManager(this)

        val myAdapter = Adapter(FilmeRepository.filmes)
        rcm.adapter = myAdapter

        fabReturn.setOnClickListener { finish() }
    }
}
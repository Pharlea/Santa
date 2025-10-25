package br.unisanta.approom.model

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey

@Entity
data class User(
    @PrimaryKey(autoGenerate = true)
    val Uid:Int,
    @ColumnInfo("first_name")
    val firstName:String,
    @ColumnInfo("last_name")
    val lastName:String
)

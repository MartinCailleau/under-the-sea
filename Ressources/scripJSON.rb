#encoding: UTF-8
file = File.open("data.json", 'a')

new_piece = true
new_object = true

object_number = 0

piece_number = 0

file.puts("{")

while new_piece
	piece_number += 1
	file.puts( "	'bande"+piece_number.to_s+"': {")

	while new_object
		object_number += 1
		p "Entrez le nom"

		name = gets.chomp

		p "Entrez le chiffre depuis le bord gauche"

		g = gets.chomp

		p "Entrez le chiffre depuis le bord haut"

		h = gets.chomp

		file.puts("		'obj"+object_number.to_s+"':{")
		file.puts("			'name' : '"+name+",")
	 	file.puts("			position : [" + g + ", "+ h +"]")
		file.puts("		}")

		p "Nouvel obstacle ? y/n"
		no = gets.chomp
		no == "n" ? new_object = false : (file.puts(","))
	end
	file.puts("	}")

	p "Nouvelle bande ? y/n"
	np = gets.chomp
	np == "n" ? new_piece = false : (file.puts(",") ; new_object = true ; object_number = 0)
end
file.puts("}")

file.close

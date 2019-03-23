#!/bin/bash
block=512
file_name=$(mktemp)
for file in $(ls)
do
	wc -m $file >> "$file_name"
done
sorted=$(mktemp)
sort -bn "$file_name" | cut -d' ' -f 2 > "$sorted"
for file in $(cat "$sorted")
do
        cat $file >> result
        if [[ "$(wc -c result | cut -d' ' -f 1)" -gt block ]]
        then
		echo "Размер результирующего файла превысил размер блока и составил:"$(wc -c result | cut -d' ' -f1) "байт(a)"
	break
        fi
done
if [[ "$(wc -c result | cut -d' ' -f 1)" -lt block ]]
then
	echo "Размер результирующего файла не превысил размер блока и составил:"$(wc -c result | cut -d' ' -f1)" байт(а)"
fi

if [[ "$(find . -name '*.tf' -not -path '*.terraform*' -printf '%h\n' | sort -u | wc -l)" -lt "200" ]]; 

then 
    yq -i 'del(.updates.[])' .github/dependabot.yml && 
    for DIR in $(find . -name '*.tf' -not -path '*.terraform*' -printf '%h\n' | sort -u); 
    do 
        dir=${DIR:1} yq -i '."updates"+=[{"package-ecosystem":"terraform" | . style="double","directory":env(dir) | . style="double","schedule":{"interval":"daily" | . style="double"}}]' .github/dependabot.yml; 
    done;
fi 

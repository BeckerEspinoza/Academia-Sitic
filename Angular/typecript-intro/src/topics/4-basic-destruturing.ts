interface AudioPlayer {
    audioVolume: number,
    songDuration: number,
    song: string,
    details: Details
}

interface Details {
    author: string,
    year: number
}

const audioPlayer: AudioPlayer = {
    audioVolume: 90,
    songDuration: 36,
    song: "Misery Business",
    details: {
        author: "Hayley Williams",
        year: 2007
    }
};

console.log('song', audioPlayer.song)
console.log('duration', audioPlayer.songDuration)
console.log('volume', audioPlayer.audioVolume)

const { song: anotherSong, songDuration: duracion, audioVolume} = audioPlayer;
console.log({anotherSong, duracion, audioVolume});

const { author: theAuthor, year: released} = audioPlayer.details;
console.log({theAuthor, released});

// const team7: string[] = ['Naruto', 'Sasuke', 'Sakura'];

// console.log('Personaje 3', team7[3] || 'No encontrado');

// const sakura = team7[3] || 'No encontrado';
// console.log('Personaje 3', sakura);

const [Naruto, Sasuke, Sakura]: string[] = ['Naruto', 'Sasuke', 'Sakura'];
const [, , sakura = 'No encontrado']: string[] = ['Naruto', 'Sasuke', 'SasuSaku'];
console.log(Naruto);
console.log(sakura);

export{};
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapyCupOverlay
{
    class Question
    {
        private readonly int[] mPoints;

        public string Title { get; set; }
        public QuestionItemList Items { get; set; }

        public Question(string title, QuestionItemList items)
        {
            Title = title;
            Items = items;
            mPoints = items.Select(i => i.Item2).ToArray();
        }

        public int GoodAnswer(int index)
        {
            int score = mPoints[index];

            if (!Items[index].Item3 && score > 0)
                mPoints[index]--;

            return score;
        }

        public static Question[] Questions = 
        {
            new Question("All you need is love", new QuestionItemList
            {
                { "Titre", 2 },
                { "Groupe", 2 },
                { "Compositeur", 3 },
                { "Année", 2, false }
            }),
            new Question("Hallelujah", new QuestionItemList
            {
                { "Titre", 2 },
                { "Interprète", 3 },
                { "Compositeur", 3 },
                { "Année", 2, false }
            }),
            new Question("Séries", new QuestionItemList
            {
                { "Winter is coming", 3 },
                { "Everybody lies", 3 },
                { "C'est pas faux !", 3 },
                { "Je t'aime", 3 },
                { "After 2AM", 3 },
                { "Chevron seven", 3 }
            }),
            new Question("L'histoire éternelle", new QuestionItemList
            {
                { "Titre", 2 },
                { "Personnage", 3 },
                { "Interprète", 3 },
                { "Dessin animé", 2 },
                { "Année", 2, false }
            }),
            new Question("Tainted Love", new QuestionItemList
            {
                { "Titre", 3 },
                { "Groupe", 3 },
                { "Chanteur", 3 },
                { "Originaux", 3 },
                { "Année compo", 2, false },
                { "Année reprise", 2, false }
            }),
            new Question("Tintin", new QuestionItemList
            {
                { "Titre", 2 },
                { "Episode", 3 },
                { "Prénom gauche", 3 },
                { "Prénom droite", 3 },
                { "Année", 2, false }
            }),
            new Question("Formidable", new QuestionItemList
            {
                { "Titre", 3 },
                { "Interprète", 3 },
                { "Année", 2, false }
            }),
            new Question("Bonhomme de neige", new QuestionItemList
            {
                { "Titre", 3 },
                { "Interprète", 3 },
                { "Compositeur", 3 }
            }),
            new Question("Nostalgies", new QuestionItemList
            {
                { "Titre", 3 },
                { "Interprète", 3 },
                { "Comédie musicale", 3 },
                { "Année", 2, false }
            }),
            new Question("Dessins animés", new QuestionItemList
            {
                { "Qui 1", 2 },
                { "Disney 1", 2 },
                { "Qui 2", 2 },
                { "Disney 2", 2 },
                { "Qui 3", 2 },
                { "Disney 3", 2 },
                { "Qui 4", 2 },
                { "Disney 4", 2 },
                { "Qui 5", 2 },
                { "Disney 5", 2 },
                { "Qui 6", 2 },
                { "Disney 6", 2 },
            }),
            new Question("Treasure", new QuestionItemList
            {
                { "Titre", 3 },
                { "Chanteur", 3 },
                { "Album", 3 },
                { "Année", 3 },
                { "Instrument", 5, false }
            }),
            new Question("Boten Anna", new QuestionItemList
            {
                { "Titre", 3 },
                { "Signification", 2 },
                { "Compositeur", 3 },
                { "Langue", 3 }
            }),
            new Question("Musique de film", new QuestionItemList
            {
                { "Titre", 3 },
                { "Compositeur", 3 },
                { "Bâtiment", 3 },
                { "Année", 2, false }
            }),
            new Question("Vivaldi", new QuestionItemList
            {
                { "Tempo", 2 },
                { "Nom pop. morceau", 2 },
                { "Nom pièce", 2 },
                { "Nom pop. pièce", 2 },
                { "Nom pop. oeuvre", 2 },
                { "Compositeur", 2 },
                { "Année", 2, false }
            }),
            new Question("Imagine Dragons", new QuestionItemList
            {
                { "Groupe", 3 },
                { "Titre", 3 },
                { "Jeu vidéo", 3 },
                { "Autre chanson", 3 }
            }),
            new Question("Comédies musicales", new QuestionItemList
            {
                { "Qui 1", 2 },
                { "Disney 1", 2 },
                { "Qui 2", 2 },
                { "Disney 2", 2 },
                { "Qui 3", 2 },
                { "Disney 3", 2 },
                { "Qui 4", 2 },
                { "Disney 4", 2 },
                { "Qui 5", 2 },
                { "Disney 5", 2 },
                { "Qui 6", 2 },
                { "Disney 6", 2 },
                { "Qui 7", 2 },
                { "Disney 7", 2 },
                { "Qui 8", 2 },
                { "Disney 8", 2 },
            }),
            new Question("La vie en rose", new QuestionItemList
            {
                { "Titre", 2 },
                { "Chanteuse reprise", 3 },
                { "Chanteuse originale", 2 },
                { "X-Men", 2 },
                { "Année", 2, false }
            }),
            new Question("Eye of the tiger", new QuestionItemList
            {
                { "Titre", 2 },
                { "Groupe", 3 },
                { "Année", 2, false }
            }),
            new Question("Bébés 1", new QuestionItemList
            {
                { "Bébé gauche", 4 },
                { "Bébé droite", 4 },
            }),
            new Question("Bébés 2", new QuestionItemList
            {
                { "Bébé gauche", 4 },
                { "Bébé droite", 4 },
            }),
            new Question("Bébés 3", new QuestionItemList
            {
                { "Bébé gauche", 4 },
                { "Bébé droite", 4 },
            }),
            new Question("Bébés 4", new QuestionItemList
            {
                { "Bébé gauche", 4 },
                { "Bébé droite", 4 },
            }),
            new Question("Que disent les chansons", new QuestionItemList
            {
                { "Titre", 3 },
                { "3 chanteurs", 4 },
                { "Album", 3 },
                { "Année", 2, false }
            }),
            new Question("Abba", new QuestionItemList
            {
                { "Titre", 3 },
                { "Groupe", 2 },
                { "Année", 2, false },
                { "Chanson Eurovision", 3 },
                { "Année Eurovision", 2 }
            }),
            new Question("Retour vers le futur", new QuestionItemList
            {
                { "Série", 3 },
                { "Héros", 2 },
                { "Carburant", 2 },
                { "Année hoverboards", 2 },
                { "Mois hoverboards", 2 }
            }),
            new Question("Valse des fleurs", new QuestionItemList
            {
                { "Titre", 3 },
                { "Ballet", 3 },
                { "Compositeur", 3 },
                { "Année", 2, false },
                { "Ville", 3 }
            }),
            new Question("Man, I feel like a woman", new QuestionItemList
            {
                { "Titre", 3 },
                { "Interprète", 3 },
                { "Album", 3 },
                { "Année", 2, false }
            }),
        };
    }

    class QuestionItemList : List<Tuple<string, int, bool>>
    {
        public void Add(string name, int score)
        {
            Add(new Tuple<string, int, bool>(name, score, false));
        }

        public void Add(string name, int score, bool degressive)
        {
            Add(new Tuple<string, int, bool>(name, score, degressive));
        }
    }
}

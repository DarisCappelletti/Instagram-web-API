# Instagram-web-API
Progetto in .net Core API per chiamate Instagram

# Utilizzo
Ho creato questo repository a titolo di studio.
Il progetto può essere scaricato e lanciato in locale per effettuare direttamente le chiamate da interfaccia web tremite Swagger.

Sono presenti 3 tipi di chiamata:

#### Ricerca tramite testo di un utente
Restituisce un elenco di utenti in base al testo inserito

```json
{
  "users": [
    {
      "position": 0,
      "user": {
        "has_anonymous_profile_picture": true,
        "pk": "string",
        "pk_id": "string",
        "strong_id__": "string",
        "username": "string",
        "full_name": "string",
        "is_private": true,
        "is_verified": true,
        "profile_pic_id": "string",
        "profile_pic_url": "string",
        "has_opt_eligible_shop": true,
        "account_badges": [
          null
        ],
        "latest_reel_media": 0,
        "should_show_category": true,
        "linked_fb_info": {
          "linked_fb_user": {
            "id": "string",
            "name": "string",
            "is_valid": true
          }
        }
      }
    }
  ],
  "places": [
    null
  ],
  "hashtags": [
    {
      "position": 0,
      "hashtag": {
        "name": "string",
        "media_count": 0,
        "use_default_avatar": true,
        "search_result_subtitle": "string"
      }
    }
  ],
  "has_more": true,
  "rank_token": "string",
  "status": "string"
}
```

#### Informazioni utente
Restituisce i dati di un utente instagram in base allo username

```json
{
  "data": {
    "user": {
      "biography": "string",
      "bio_links": [
        {
          "title": "string",
          "lynx_url": "string",
          "url": "string",
          "link_type": "string"
        }
      ],
      "biography_with_entities": {
        "raw_text": "string",
        "entities": [
          null
        ]
      },
      "blocked_by_viewer": true,
      "country_block": true,
      "external_url": "string",
      "external_url_linkshimmed": "string",
      "edge_followed_by": {
        "count": 0
      },
      "fbid": "string",
      "followed_by_viewer": true,
      "edge_follow": {
        "count": 0
      },
      "follows_viewer": true,
      "full_name": "string",
      "has_ar_effects": true,
      "has_clips": true,
      "has_guides": true,
      "has_channel": true,
      "has_blocked_viewer": true,
      "highlight_reel_count": 0,
      "has_requested_viewer": true,
      "hide_like_and_view_counts": true,
      "id": "string",
      "is_business_account": true,
      "is_professional_account": true,
      "is_supervision_enabled": true,
      "is_guardian_of_viewer": true,
      "is_supervised_by_viewer": true,
      "is_supervised_user": true,
      "is_embeds_disabled": true,
      "is_joined_recently": true,
      "business_contact_method": "string",
      "category_name": "string",
      "is_private": true,
      "is_verified": true,
      "edge_mutual_followed_by": {
        "count": 0,
        "edges": [
          null
        ]
      },
      "profile_pic_url": "string",
      "profile_pic_url_hd": "string",
      "requested_by_viewer": true,
      "should_show_category": true,
      "should_show_public_contacts": true,
      "transparency_product": "string",
      "username": "string",
      "pronouns": [
        null
      ],
      "edge_related_profiles": {
        "edges": [
          null
        ]
      }
    }
  },
  "status": "string"
}
```

#### Lista Followers
Questa particolare chiamata non restituisce risultati se non si possiede determinati "header" da impostare sulla chiamata.
Questo perchè Instagram blocca i tentativi di visione dei dati agli utenti "non loggati".
Restituisce la lista degli utenti che seguono l'utente con l'id che impostiamo.

# Terms and conditions
Provided project MUST NOT be used for marketing purposes
I will not provide support to anyone who wants this API to send massive messages/likes/follows and so on
Use this API at your own risk

# Legal
This code is in no way affiliated with, authorized, maintained, sponsored or endorsed by Instagram or any of its affiliates or subsidiaries. This is an independent and unofficial API.

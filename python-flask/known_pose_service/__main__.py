#!/usr/bin/env python3

import connexion

from known_pose_service import encoder


def main():
    app = connexion.App(__name__, specification_dir='./swagger/')
    app.app.json_encoder = encoder.JSONEncoder
    app.add_api('swagger.yaml', arguments={'title': 'Known Pose API'}, pythonic_params=True)
    app.run(port=9092)


if __name__ == '__main__':
    main()
